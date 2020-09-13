/**
 * Exmaple: Events
 * 
 * The example consists of three GameObjects:
 * - a button invoking the event
 * - an event manager holding the event itself
 * - a text listening to the event
 * 
 * Setting up the GameObjects:
 * - Button:
 *   - add a script component (EventButton.cs)
 *   - add an OnClick() event using the Button itself, calling EventButton.OnButtonClick
 * - Text:
 *   - add the EventText script as a component
 * - EventManager:
 *   - add the EventManager script component
 * Everything else is done in code in those three classes.
 * 
 */