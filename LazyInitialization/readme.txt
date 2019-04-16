--------------------------------------------------------------------------------------
                ___                                          
 |   _. _        |  ._  o _|_ o  _. | o _   _. _|_ o  _  ._  
 |_ (_| /_ \/   _|_ | | |  |_ | (_| | | /_ (_|  |_ | (_) | | 
           /                                                 
--------------------------------------------------------------------------------------

Lazy initialization is a creational object pattern with focus on performance situations.
The idea is to defer the creation saving in memory the frequent objects after to be consulted.
In that way on future consulting, these objects will ready into volatile memory and these won't
need to be created again. 