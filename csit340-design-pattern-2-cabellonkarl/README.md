# Invoice App
## Application Overview
This application has **5 clients** (0, 1, 2, 3 ,4). It generates, display, and saves an invoice.

### Invoice Generation & Display
1. `Client 0` - wants to generate and display a simple invoice (includes the body only).
2. `Client 1` - wants to generate and display an invoice with a header.
3. `Client 2` - wants to generate and display an invoice with a footer *(he might want to display it in `GREEN` in the future)*. 
4. `Client 3` - wants to generate and display an invoice with a header and footer. 
4. `Client 4` - wants to generate an invoice with a header and footer but display it in `RED` font. 

### Invoice Saving
1. `Client 0` - wants the data to be encrypted with CeasarCipher.
2. `Client 1` - wants the data to be encrypted with CeasarCipher.
3. `Client 2` - wants the data to be encrypted with WeirdCipher.
4. `Client 3` - wants the data to be encrypted with WeirdCipher.
4. `Client 4` - doesn't want his data to be encrypted *(but he might in the future)*.


## Task

### Refactor Existing Solution
Refactor the existing code of the previous developer to make it flexible and .
 - Follow SOLID Principles
 - You'll have to use more than one design pattern for this
 - Document code

### UML Diagram for the Refactored Version
`<insert UML here>`
![Progam drawio](https://user-images.githubusercontent.com/116715535/202866097-4528fbcb-2882-4eab-8cbb-029958f74332.png)
### Explanation
Explain here what design patterns did you use, why did you use it, how does it solve the problem, etc.

The design patterns I used is first is the Decorator Pattern to simply wrap the Invoice too simple wrap and add different attributes toward invoice its to shorten and dynamically use the attributes inside. So makause nako og with Header and Footer Together . Another design pattern I used is bridge PAttern for the Display Behavior I called it inside the Invoice its to actually separate the class nga DisplayBehavior but still connected dyapun siya to the Invoice that is why I used Bridge so dli siya musamok sa what is inside the Invoice. Another One is Abstract Factory Method which ako giuse sa Client so I can call the other classes Invoice and Cipher para mas mo clean akong InvoiceProcessor since I can call classes nga iya gi use like Invoice and Cipher I called it.

