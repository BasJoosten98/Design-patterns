using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
	public class Caller
	{
        private List<ICommand> animations;
        private int currentAnim = 0;

        public Caller()
        {
            animations = new List<ICommand>();
        }
		public bool CallNextAnimation()
		{
			if(animations.Count > 0)
            {
                if(currentAnim > animations.Count - 1)
                {
                    currentAnim = 0;
                    return false;
                }
                animations[currentAnim].Execute();
                currentAnim++;
                return true;
            }
            return false;
		}

		public void AddAnimation(ICommand Anim)
		{
            animations.Add(Anim);
		}
	}
}
