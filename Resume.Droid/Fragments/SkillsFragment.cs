using Android.OS;
using Android.Views;
using Android.Widget;
using System;

namespace Resume.Droid.Fragments
{
    public class SkillsFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public static SkillsFragment newInstance(int imageResourceId, String skillText)
        {
            SkillsFragment fragment = new SkillsFragment();

            Bundle args = new Bundle();
            args.PutInt("ImageResourceId", imageResourceId);
            args.PutString("SkillText", skillText);
            fragment.Arguments = args;

            return fragment;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            int imageResourceId = Arguments.GetInt("ImageResourceId", 0);
            string skilText = Arguments.GetString("SkillText", "");

            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.fragment_skills, container, false);
            
            TextView text = (TextView)view.FindViewById(Resource.Id.txt_skill_frag);
            text.Text = skilText;

            ImageView image = (ImageView)view.FindViewById(Resource.Id.img_skill_frag);
            image.SetImageResource(imageResourceId);

            return view;
        }
    }
}