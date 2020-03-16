using MarvelWorld.Domain;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace MarvelWorld.Tests
{
    [Binding]
    public class HumanSteps
    {
        [Given(@"List of humans")]
        public void GivenListOfHuman(Table table)
        {
            var humans = table.CreateSet<Human>();

            foreach (var human in humans)
            {
                human.WhoIAm();
            }

            Assert.Contains(humans, h => h.iAmHuman);
        }
    }
}
