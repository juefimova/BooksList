# Book Management Application

This is a simple book management application developed in C# using Visual Studio. The application allows users to add different types of books (paper books, e-books, and audio books) to a text file, and later retrieve and display them.

## Features

1. **Add Books:** Users can add paper books, e-books, and audio books to the library by providing relevant information such as title, author, category, and specific details based on the book type.

2. **Book Types:** The application supports three types of books: paper books, e-books, and audio books. Users can specify the type of book they are adding and provide additional information accordingly.

3. **File Storage:** All added books are stored in a text file for easy retrieval and persistence across sessions.

## Installation

1. Clone this repository to your local machine.

2. Open the project in Visual Studio.

3. Build and run the project.

## Usage

1. Launch the application.

2. Click on the "Add Book" button to add a new book to the library.

3. Choose the type of book (paper book, e-book, or audio book) from the dropdown menu.

4. Enter the required information such as title, author, category, and additional details based on the selected book type.

5. Click the "Save" button to add the book to the library.

6. To view or edit existing books, click on the "View/Edit Books" button.

7. In the "View/Edit Books" window, use the navigation buttons to move between different books.

8. To edit a book, click the "Edit" button, make changes to the book details, and click "Apply" to save the changes.

9. To delete a book, click the "Delete" button.

## Credits

This book management application was created by Yuliya Yafimava.

## Code Structure

The application consists of three forms (`Form1`, `Form2`, and `Form3`) and several supporting classes (`Book`, `PaperBook`, `EBook`, `AudioBook`, and `Library`) to manage book data and operations.

### `Form1`

This form serves as the main interface for adding new books to the library. It allows users to select the type of book they want to add and provides input fields for entering book details.

### `Form2`

This form is used to display and edit existing books in the library. Users can navigate between different books, edit their details, and delete books if needed.

### `Form3`

This form provides a user-friendly interface for viewing and navigating through existing books in the library. It displays book details and allows users to edit or delete books.
