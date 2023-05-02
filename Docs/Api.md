#Uber Dinner API
- [Uber Dinner API](#Uber-dinner-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request) 
            - [Register Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register
 ``` js
POST {{host}}/auth/register
```

### Register Request

``` json
{
    "firstName": "Nawar",
    "lastName": "Ali",
    "email": "nr.ali1912@gmail.com",
    "password": "Nawar12321"
}
```

### Register Response

``` js
200 OK
```

``` json
{
    "id": "d89c2d9a-eb3e-4065-95ff-b920b55aa105",
    "firstName": "Nawar",
    "lastName": "Ali",
    "email": "nr.ali1912@gmail.com",
    "token": "eyJhb....z0daceXoy"
}
```