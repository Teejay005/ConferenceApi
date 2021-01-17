# ConferenceApi

## Question:
```
Given a developer wants to get a list of session and topics together

When it sends an API request with the speaker name, date and time slot 

Then the API will respond with all possible values available
```

## My Understanding:

My understanding is that a session consist of a speaker, title and list of topics to be discussed.

Therefore I have a session model structure below:

```
public Speaker Speaker
public string Title
public string Timeslot
public string Date
public List<Topic> Topics 
```

## The API

The api is authenticated using API key. I also added IP whitelisting for approved IPs. At present this is disbale using `Debug Mode` settings. This will be set to false in PRODUCTION.

## Area of improvement:
- Add a database layer for data processing
- Capture more user details and log in azure queue for later processing
- Failing validation is throwing exception at the moment. This will be corrected to return more meaningful/helpful message.
