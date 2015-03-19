

import twitter4j.TwitterException;

public class populator {

	public static void main(String[] args) {

		twitterRequester poster = new twitterRequester();
//		try {
//			poster.PostingToTwitter("Another test message, again");
//		} catch (TwitterException e) {
//			System.out.println(e.getMessage());
//		}

		try {
			poster.getUserInfo("abdel");
		} catch (TwitterException e) {
			System.out.println(e.getMessage());
		}
		
//		try {
//			poster.getTweet();
//		} catch (TwitterException e) {
//			// TODO Auto-generated catch block
//			System.out.println(e.getMessage());
//		}
	

	}
}
