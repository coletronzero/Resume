using Android.OS;
using Android.Support.V4.View;
using Android.Views;
using Resume.Droid.Adapters;
using System.Collections.Generic;

namespace Resume.Droid.Fragments
{
    public class HomeFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

            var skillsPager = view.FindViewById<ViewPager>(Resource.Id.skills_pager);
            skillsPager.PageMargin = 40;
            skillsPager.OffscreenPageLimit = 3;
            
            if (skillsPager != null)
            {
                var skills = new List<Skill>()
                {
                    new Skill(Resource.Mipmap.ic_launcher, "Xamarin"),
                    new Skill(Resource.Mipmap.ic_launcher, ".NET"),
                    new Skill(Resource.Mipmap.ic_launcher, "C#")
                };

                skillsPager.Adapter = new SkillCardAdapter(FragmentManager, skills);
            }

            return view;
        }
    }
}