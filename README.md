# Rock Paper Scissors Game

This is a simple console-based Rock Paper Scissors game written in C#. The game allows you to play against the computer or a friend. The game continues until one of the players reaches the specified number of rounds.

## Features

- Play against the computer
- Play against a friend
- Set the number of rounds to win the game

## Getting Started

### Prerequisites

- .NET SDK

### Running the Game

1. Clone the repository or download the source code.
2. Open a terminal and navigate to the project directory.
3. Run the following command to start the game:

   ```sh
   dotnet run
   ```

## How to Play

1. **Select Game Mode**: When prompted, choose one of the following options:
   - `1`: Play against the computer
   - `2`: Play against a friend
   - `3`: Exit the game

2. **Set Rounds**: Enter the number of rounds you want the game to end at (between 1 and 30).

3. **Gameplay**:
   - If playing against the computer, enter your choice (Rock, Paper, or Scissors) when prompted.
   - If playing against a friend, both players will enter their choices (Rock, Paper, or Scissors) when prompted.

4. The game will display the result of each round and the current score.

5. The game ends when one of the players reaches the specified number of rounds. The final score and the winner will be displayed.

## Code Structure

- `Program.cs`: Contains the main logic for the game, including the game loop and methods for playing against the computer and a friend.
- `Choice` Enum: Represents the possible choices (Rock, Paper, Scissors).

## Error Handling

- The game handles invalid input for game mode and rounds by prompting the user to enter a valid option.
- If a non-numeric value is entered for the number of rounds, the game will prompt the user to enter a numeric value.

## Example

```sh
Welcome to the rock paper scissors game please select an option
Options:
1. play against computer
2. play against friend
3. exit
Your choice: 1
What score would you like the game to end at? Enter a number between 1 and 30: 3
Round 1
Enter your choice (Rock, Paper, Scissors): rock
Computer chose: scissors
Player win this round!
Round 1 Score: Player- 1 Computer- 0
...
Final Score: Player- 3 Computer- 1
Player win this game!
```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
