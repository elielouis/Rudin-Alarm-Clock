namespace CaptchaPluginsFramework
{
    public struct CaptchaChallenge
    {
        public string ChallengeQuestion;
        public string ChallengeAnswer;

        public CaptchaChallenge(string question, string answer)
        {
            ChallengeQuestion = question;
            ChallengeAnswer = answer;
        }
    }
}
