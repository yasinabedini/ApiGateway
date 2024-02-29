Guide to using the project
------------------------------------
1. First, you need to pull the Eureka Container --> 'docker run --publish 8761:8761 steeltoeoss/eureka-server'
2. In the next step, you must run all the projects. Api projects that are supposed to provide a service register themselves in Eureka using the settings in Appsetting.
3. Our Api Gateway project, using the settings in Appsetting, uses the projects that are registered in Eureka and provides services to Client.
4. Now the client project only has access to ApiGateway
