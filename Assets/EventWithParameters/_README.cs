/**
 * Exmaple: EventsWithParameters
 * 
 * The example consists of five GameObjects:
 * - two input fields holding the parameters
 * - a button invoking the event
 * - an event manager holding the event itself
 * - a text listening to the event, showing the input field's content
 * 
 * Setting up the GameObjects:
 * - Button:
 *   - add a script component: EventWithParameters_Button.cs
 *   - connect the two input fields to the button's script
 *   - in the Button component add an OnClick() event using the Button itself, calling EventWithParameters_Button.OnClick()
 * - Text:
 *   - add a script component: EventWithParameters_Text.cs
 * - EventManager:
 *   - add a script component: EventWithParameters_EventManager.cs
 * Everything else is done in code.
 * 
 */