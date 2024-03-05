## Cryptocurrency App

Cryptocurrency App is a multi-page application developed using the Model-View-ViewModel (MVVM) pattern. It utilizes the CoinCap API 2.0 to fetch cryptocurrency data.

### Features

- **Main Page**: Displays a list of the top 10 cryptocurrencies.
- **Search**: Allows users to search for specific cryptocurrencies.
- **Cryptocurrency Info Page**: Provides detailed information about a selected cryptocurrency, including its name, price, volume, and change percentage.
- **Navigation**: Implements navigation between different pages.

### Technologies Used

- C#
- MVVM Pattern
- CoinCap API 2.0

### Project Structure

The project consists of several ViewModel classes responsible for managing the application's logic and UI, including:
- `MainViewModel`: Manages navigation and displays the current view model.
- `MainPageViewModel`: Handles data related to the main page, including fetching the top 10 cryptocurrencies and handling search functionality.
- `CryptocurrencyInfoViewModel`: Provides detailed information about a selected cryptocurrency.
- `ViewModel`: Base class for ViewModels, implementing the INotifyPropertyChanged interface.
- `NavigationStore`: Stores the current ViewModel and triggers events when it changes.
- `CurrencyInfo`, `CurrencyList`, `CurrencyMarket`: Classes for fetching cryptocurrency data from the CoinCap API.

### Commands

#### CommandBase
`CommandBase` is an abstract class that implements the `ICommand` interface. It has a `CanExecuteChanged` event and `CanExecute` and `Execute` methods, which allow checking whether a command can be executed and executing it accordingly. This class serves as the base class for all other commands.

#### NavigateOnMainCommand
`NavigateOnMainCommand` is a class that implements a command for navigating to the main page of the application. It takes an instance of the `NavigationStore` and sets the main page as the current view model when the `Execute` method is called.

#### RelayCommand
`RelayCommand` is a class that implements a command capable of executing methods passed via a delegate. It allows defining a condition for executing the command. This class is widely used for binding commands to elements in the user interface.

#### SearchCommand
`SearchCommand` is a class that implements a command for searching cryptocurrencies. It takes an instance of the `NavigationStore` and when the `Execute` method is called, it checks if the entered cryptocurrency exists in the list of available ones, and if so, sets the cryptocurrency details page as the current view model.

### How to Use

1. Clone the repository.
2. Ensure you have the necessary dependencies installed.
3. Build and run the application.
4. Explore the different pages and functionalities provided by the app.

---

Feel free to contribute and enhance this project! If you encounter any issues or have suggestions, please create an issue or submit a pull request.
