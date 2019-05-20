using FluentAssertions;
using System;
using Xunit;
using CodingDojo02;

namespace CodingDojo02.Test
{
    public class UnitTest1
    {
        [Fact]
        public void should_return000vs000_atMatchStart()
        {
            // given
            ScoreKeeper scoreKeeper = new ScorersTable();
            
            // when
            string score = scoreKeeper.getScore();

            // then
            score.Should().Be("000:000");
        }

        [Fact]
        public void should_return001vs000_whenTeamAScoreOnePoint()
        {
            // given
            ScoreKeeper scoreKeeper = new ScorersTable();

            // when
            scoreKeeper.scoreTeamA1();
            string score = scoreKeeper.getScore();

            // then
            score.Should().Be("001:000");
        }

        [Fact]
        public void should_return002vs000_whenTeamAScoreOnePoint()
        {
            // given
            ScoreKeeper scoreKeeper = new ScorersTable();

            // when
            scoreKeeper.scoreTeamA2();
            string score = scoreKeeper.getScore();

            // then
            score.Should().Be("002:000");
        }
    }
}
