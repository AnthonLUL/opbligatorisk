import time
from sense_hat import SenseHat

sense = SenseHat()

# Set the humidity range
min_humidity = 25
max_humidity = 45

while True:
    # Get the humidity from the Sense HAT
    humidity = sense.get_humidity()

    # Set the display color based on the humidity level
    if humidity < min_humidity:
        color = (255, 0, 0)  # red
    elif humidity > max_humidity:
        color = (0, 0, 255)  # blue
    else:
        color = (0, 255, 0)  # green

        # Display the humidity on the LED matrix
    sense.clear()
    sense.show_message(str(round(humidity)), text_colour=color)

    # Wait for a while before updating the humidity again
    time.sleep(1)
