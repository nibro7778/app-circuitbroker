# demo-application-circuit-breaker
This repo provides you a basic understanding to implement circuit breaker with Polly nuget package. This repository contains following project and class library

## Component list in this repo

**Website:** Own MVC application to demonstrate external service call using the circuit breaker

**InternalService:** This class library makes a call to external services using the circuit breaker pattern

**Circuit Breaker:** This class library contains an implementation of circuit breaker design pattern using Polly. This class library used by internal service

**ExternalService:** External service is web API project. we will be going to call external service's web API from our MVC web application

## How to use it

Please first get understanding of circuit breaker what it is and how it is important for enterprise application. I have also created blog post for it [Learn about Circuit Breaker](https://nirajtrivediblog.wordpress.com/2018/03/16/circuit-breaker-design-pattern/)

## Feedback

let me know if you come across any issues or any ideas for improvement. Open an issue!
