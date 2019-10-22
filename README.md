# Coding assignment. Week 7 (2019).

[![Join the chat at https://gitter.im/kmaooad/coding-19W07](https://badges.gitter.im/kmaooad/coding-19W07.svg)](https://gitter.im/kmaooad/coding-19W07?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
<NEVER BUILT>

### Task

**Implement balance calculation for billing data.**

`Client.fs` contains only one function `balance()` that you need to implement in this task.

#### Data source

In this task you will work with [fake JSON server](http://my-json-server.typicode.com/kmaooad/fancy-billing) and make real HTTP requests to it. JSON server provides fake data for customers, their usage and payments. You can request necessary data from endpoints, e.g. payments from [http://my-json-server.typicode.com/kmaooad/fancy-billing/payments](http://my-json-server.typicode.com/kmaooad/fancy-billing/payments). It is also possible to add query string parameters to request only specific data, e.g. [http://my-json-server.typicode.com/kmaooad/fancy-billing/payments?customer=930](http://my-json-server.typicode.com/kmaooad/fancy-billing/payments?customer=930).

#### Balance calculation

Balance for a given customer and period can be calculated from services used in this period as sum of used amount (`quantity` field in `usage`) multiplied by price per unit (`pricing` field in `plans`). Every customer has specific plan assigned.

#### Making HTTP requests

The simplest (and recommended) way to make HTTP requests in F# is to use [FSharp.Data](https://fsharp.github.io/FSharp.Data/library/Http.html) library.

#### Logging empty responses 

The most interesting part of this task is implementation of logging of empty HTTP responses. For this you are provided with fake logger `Logger404`. (It imitates external trace with a mutable state variable.) *Think about some convenient way to use this logger in your HTTP requests globally.*

### Design thinking

Carefully check your dependencies. Do you anticipate any *design smells* in your implementation? How much *cohesive* and *coupled* are your functions? How many responsibilities does each function hold? Do you have any dependency on concrete implementation rather than abstraction? **In this task actual implementation is not as important as deep insight into design approach you take, so pay special attention to understanding every move you make.**

### (Optional) Impact of changes

What if data API changes? In current version payments and refunds are stored together, but what if they will be stored separately, as in [db2.json](https://github.com/kmaooad/fancy-billing/blob/master/db2.json)? How much change will be required in your implementation to support new data API? You can use alternative data file and make your own JSON server to work on updated implemenation. 

### (Optional) Peer review

As before, it is highly recommended to do some code review for your classmates and ask for code review from others. Discuss your points of view and chosen approaches.

