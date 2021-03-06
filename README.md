## REST APIS

1. GET: Returns all fields of all intervention Request records that do not have a start date and are in "Pending" status.<br>

![alt text](https://github.com/Phanourith/Rocket_Elevators_Foundation_REST_API/blob/main/GET_Method.png)<br>

Put The following URL in POSTMAN with GET<br>

http://localhost:5000/api/interventions/get-pendings<br>

<em>PRESS SEND</em><br>

2. PUT: Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).<br>

Do the following like the picture below<br>

URL: http://localhost:5000/api/interventions/start/5<br>

Type inside the body in POSTMAN: `{
    "status": "InProgress"
}`

![alt text](https://github.com/Phanourith/Rocket_Elevators_Foundation_REST_API/blob/main/PUT_Method_InProgress.png)<br>

3. PUT: Change the status of the request for action to "Completed" and add an end date and time (Timestamp).<br>

Do the following like the picture below<br>

URL: http://localhost:5000/api/interventions/start/5<br>

Type inside the body in POSTMAN: `{
    "status": "Completed"
}`

![alt text](https://github.com/Phanourith/Rocket_Elevators_Foundation_REST_API/blob/main/PUT_Method_Complete.png)<br>

## VIDEO EXPLANATION

<em>LINK:</em>https://youtu.be/oVZrUaTP75g



