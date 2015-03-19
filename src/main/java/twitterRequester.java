

import twitter4j.Logger;
import twitter4j.Query;
import twitter4j.QueryResult;
import twitter4j.Status;
import twitter4j.Twitter;
import twitter4j.TwitterException;
import twitter4j.TwitterFactory;
import twitter4j.User;

public class twitterRequester{

	private static Logger LOG = Logger.getLogger(twitterRequester.class);	

	public void PostingToTwitter(String message)throws TwitterException{
		Twitter twitter = TwitterFactory.getSingleton();
		Status status = twitter.updateStatus(message);
		LOG.debug("Successfully updated status to " + status.getText());
	}
	
	public void getUserInfo(String username)throws TwitterException{
		Twitter twitter = TwitterFactory.getSingleton();
		User user = twitter.showUser(username);		
		
        System.out.println("\n ***************************    INFORMATION TWITTER PROFILE " + user.getScreenName() + "    ************************* \n\n");
        System.out.println("      Id:                    " + user.getId() + " \n");
        System.out.println("      Screen name:           " + user.getScreenName() + " \n");
        System.out.println("      Name:                  " + user.getName() + " \n");
        System.out.println("      Description:           " + user.getDescription() + " \n");
        System.out.println("      Image profile:         " + user.getProfileImageURL() + " \n");
        System.out.println("      Follorwers:            " + user.getFollowersCount() + " \n");
        System.out.println("      Friends:               " + user.getFriendsCount() + " \n");
        System.out.println("      Created date:          " + user.getCreatedAt() + " \n");
        System.out.println("      Language:              " + user.getLang() + " \n");
        System.out.println("      Time zone:             " + user.getTimeZone() + " \n\n");
        System.out.println(" ******************************************************************************************************");

	}
	
	public void getTweet()throws TwitterException{
		 // The factory instance is re-useable and thread safe.
	    Twitter twitter = TwitterFactory.getSingleton();
	    Query query = new Query("source:twitter4j yusukey");
	    QueryResult result = twitter.search(query);
	    for (Status status : result.getTweets()) {
	        System.out.println("@" + status.getUser().getScreenName() + ":" + status.getText());
	    }
	}
}
