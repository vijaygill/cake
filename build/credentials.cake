public record BuildCredentials(string Token)
{
    public static BuildCredentials GetGitHubCredentials(ICakeContext context)
    {
        return new BuildCredentials(
            context.EnvironmentVariable("CAKE_GITHUB_TOKEN"));
    }
}

public record TwitterCredentials(
    string ConsumerKey,
    string ConsumerSecret,
    string AccessToken,
    string AccessTokenSecret
)
{
    public static TwitterCredentials GetTwitterCredentials(ICakeContext context)
    {
        return new TwitterCredentials(
            context.EnvironmentVariable("TWITTER_CONSUMER_KEY"),
            context.EnvironmentVariable("TWITTER_CONSUMER_SECRET"),
            context.EnvironmentVariable("TWITTER_ACCESS_TOKEN"),
            context.EnvironmentVariable("TWITTER_ACCESS_TOKEN_SECRET"));
    }
}
