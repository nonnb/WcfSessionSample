WcfSessionSample
================
Here's a quick and dirty implementation of the ICalculatorService as per [MSDN}(http://msdn.microsoft.com/en-us/library/ms733040.aspx).

This demonstrates the use of WCF Sessions

Build both the service and client projects

Start the Service under the debugger

Start the client without the debugger

Ideally you should Initiate the session with "Clear" and then use the +,-,* and / operations with the input textbox, before
finally hitting the = for the result (which terminates the session).

Fiddle around to see the errors if the methods aren't called the contracted sequences.

You can also launch multiple clients - you can see how the service tracks (I've logged the session ID in the Debug.trace)
The server also keeps track of the interim calculator register 'subtotal' along the way for each session.

Also, if you launch too many clients, the server should run out of threads - one of the scalability related issues as to why
WCF Sessions are for specific purposes requiring state.
