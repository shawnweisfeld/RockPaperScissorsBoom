using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsBoom.Server.Data;
using RockPaperScissorsBoom.Server.Pages;
using RockPaperScissor.Core.Model;
using RockPaperScissor.Core.Game.Results;
using System.Collections.Generic;
using RockPaperScissor.Core.Game;
using RockPaperScissor.Core.Game.Bots;
using RockPaperScissorsBoom.Server.Bot;

namespace RockPaperScissorsBoom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunGameController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public RunGameController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public string Post()
        {
            List<Competitor> competitors = _db.Competitors.ToList();

            var gameRunner = new GameRunner();
            foreach (var competitor in competitors)
            {
                BaseBot bot = CreateBotFromCompetitor(competitor);
                gameRunner.AddBot(bot);
            }

            GameRunnerResult gameRunnerResult = gameRunner.StartAllMatches();
            SaveResults(gameRunnerResult);
            return gameRunnerResult.AllMatchResults.Select(x => x.MatchResults).First().First().Player1.Name;
        }

        private void SaveResults(GameRunnerResult gameRunnerResult)
        {
            if (gameRunnerResult.GameRecord.BotRecords.Any())
            {
                _db.GameRecords.Add(gameRunnerResult.GameRecord);
                _db.SaveChanges();
            }
        }

        private static BaseBot CreateBotFromCompetitor(Competitor competitor)
        {
            Type type = Type.GetType(competitor.BotType);
            var bot = (BaseBot)Activator.CreateInstance(type);
            if (bot is SignalRBot signalRBot)
            {
                signalRBot.ApiRootUrl = competitor.Url;
            }

            bot.Competitor = competitor;
            return bot;
        }
    }
}