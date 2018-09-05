using Android.Support.V4.App;
using Resume.Droid.Fragments;
using System.Collections.Generic;

namespace Resume.Droid.Adapters
{
    public class SkillCardAdapter : FragmentPagerAdapter
    {
        private List<Skill> _skills;

        public SkillCardAdapter(Android.Support.V4.App.FragmentManager fm, List<Skill> skills)
            : base(fm)
        {
            _skills = skills;
        }

        public override int Count
        {
            get { return _skills?.Count ?? 0; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            var skill = _skills[position];
            return SkillsFragment.newInstance(skill.ImageResourceId, skill.SkillText);
        }
    }

    public class Skill
    {
        public Skill(int imageResourcId, string skillText)
        {
            ImageResourceId = imageResourcId;
            SkillText = skillText;
        }

        public int ImageResourceId { get; private set; }
        public string SkillText { get; private set; }
    }
}