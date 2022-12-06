The HR Management project contains multiple entities in the project: Applicant, Application, Interview, Interviewer, Person (that is inherited by both interviewer and applicant), vacancy for jobs and results of interviews.

The Person entity is a class that defines basic fields belonging to a person, like name, address and qualification.
This is extended by applicant, that adds properties like applicant ID and application category that the applicant is applying for.
The person entity is also extended by interviewer class, that adds properties like InterviewerID and their Position in the organisation.

The class Application holds fields like InterviewID, date of interview, applicationID for which the interview is to be conducted, and the ID of the interviewer that is to conduct the interview. 
New Applications can be added and list of existing applications can be viewed.

The vacancy class holds fields like Vacancy ID, category and number of openings for a vacancy.

The concluding result class holds 3 fields,resultID, InterviewID and interviewResult. These fields together show what result was the outcome of an interview.