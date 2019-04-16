--------------------------------------------------------------------------------------
                ___                                          
 |   _. _        |  ._  o _|_ o  _. | o _   _. _|_ o  _  ._  
 |_ (_| /_ \/   _|_ | | |  |_ | (_| | | /_ (_|  |_ | (_) | | 
           /                                                 
--------------------------------------------------------------------------------------

Lazy initialization is a creational object pattern with focus on performance situations. The 
idea is to defer the creation saving in memory the frequent or hard-to-create objects after to
be consulted. In that way on future consulting, these objects will ready into volatile memory 
and these won't need to be created again. 
In the example, the idea is to reuse and call the project with the factory method to create the 
object "Quiz" as a result on the first request,  it will storage into the volatile memory for 
other requests.