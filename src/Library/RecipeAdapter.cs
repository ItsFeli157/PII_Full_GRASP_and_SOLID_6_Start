using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    public class RecipeAdapter : TimerClient
    {
        public RecipeAdapter(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public void TimeOut()
        {
            this.recipe.Cooked = true;
        }
        private Recipe recipe;
    }
}