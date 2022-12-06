1. Passing of data from child to parent component is an important aspect of a component based application.
2. In Angular, this process is done by creating an event that is triggered when the child component is called by the parent component.
3. The child component Passes the data to this event using the @Output functionality, that sends some data to the event on trigger.
4. A variable is created in the parent component to store the data coming from the child component and whatever processing is to be done on the data coming from the child component, is applied on this local variable.