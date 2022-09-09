using Automation.Tests;
using NUnit.Framework;

namespace Automation
{
    public class Search:BaseTest
	{
		[Test]
		public void GivenExistingIngredientName_WhenSeaching_ThenReturnsIngredient()
		{
			CockTailDB.homePage.searchBox.Click();
			CockTailDB.homePage.searchBox.SendKeys("Vodka");
			CockTailDB.homePage.searchButton.Click();
			Assert.IsTrue(CockTailDB.homePage.cocktail.Displayed);

			CockTailDB.homePage.cocktail.Click();
			Assert.IsTrue(CockTailDB.homePage.cocktailName.Text.Equals("Vodka"));
			Assert.IsTrue(CockTailDB.homePage.ingredientLabel.Text.Equals("Drinks"));
		}

		[Test]
		public void GivenExistingCocktailName_WhenSeaching_ThenReturnsCocktail()
		{
			CockTailDB.homePage.searchBox.Click();
			CockTailDB.homePage.searchBox.SendKeys("Old Fashioned");
			CockTailDB.homePage.searchButton.Click();
			Assert.IsTrue(CockTailDB.homePage.cocktail.Displayed);

			CockTailDB.homePage.cocktail.Click();
			Assert.IsTrue(CockTailDB.homePage.cocktailName.Text.Equals("Old Fashioned"));
			Assert.IsTrue(CockTailDB.homePage.ingredientLabel.Text.Equals("Ingredients"));
		}

		[Test]
		public void GivenALetter_WhenBrowsing_ThenReturnsCocktail()
		{
			CockTailDB.homePage.letter.Click();
			Assert.IsTrue(CockTailDB.homePage.cocktail.Displayed);
			Assert.IsTrue(CockTailDB.homePage.browseCocktailsLabel.Displayed);
		}

		[Test]
		public void GivenIvalidName_WhenSeaching_ThenReturnsIngredientNodrinks()
		{
			CockTailDB.homePage.searchBox.Click();
			CockTailDB.homePage.searchBox.SendKeys("test");
			CockTailDB.homePage.searchButton.Click();
			Assert.IsTrue(CockTailDB.homePage.NoDrinksLabel.Text.Equals("No drinks found"));
		}

		
	}
}
