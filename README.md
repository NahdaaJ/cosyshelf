# CosyShelf °｡⋆˚⁺
> **Note:** This project is in the beginning stages.

A cosy little book tracker for book lovers to keep up with their TBR, track what they're reading, and rate their favourites! ♡

<strong>Tech Stack:</strong> .NET, MAUI, SQLite



## ♥ Table of Contents
- [Features](#-features)
  - [Basic Features](#basic-features)
  - [Next Level Features](#next-level-features)
  - [Future Plans](#future-plans)
- [Getting Started](#-getting-started)
- [Project Structure](#-project-structure)
- [Database](#-database)
- [Get in Touch!](#-get-in-touch)

## ♥ Features

### Basic Features

- Add books with:
  - Title
  - Author
  - Description (optional)
  - Your rating (optional)
  - Comments with your rating (optional)
  - Date started, date finished (or mark as currently reading)
- Edit or delete books
- View all books
- Store data in a local SQLite database

### Next Level Features

- Query/filter books by title, author, rating, or dates
- Integrate with a book API:
  - Set up API key if needed
  - Fetch book details (title, author, description, cover image)
- Search books via API and add to local storage
- Improved UI for book search and entry

### Future Plans

- Dedicated TBR (To Be Read) page
  - New database table for TBR
  - Add books to TBR via API queries


## ♥ Getting Started

<!-- Instructions for building and running the app will go here -->


## ♥ Project Structure

The project is organised as follows:
- [`CosyShelf/CosyShelf.Core`](CosyShelf/CosyShelf.Core) - Project business logic.
- [`CosyShelf/CosyShelf.Data`](CosyShelf/CosyShelf.Data) - DB initialisation, table access, add edit delete etc.
- [`CosyShelf/CosyShelf.UI`](CosyShelf/CosyShelf.UI) - Desktop app UI using .NET MAUI.



## ♥ Database

The app uses SQLite for local storage. The main schema so far:

**Book Table**
| Column         | Type      | Description                                 |
|----------------|-----------|---------------------------------------------|
| Id             | INTEGER   | Primary key, auto-increment                 |
| Title          | TEXT      | Book title                                  |
| Author         | TEXT      | Book author                                 |
| Description    | TEXT      | Optional description                        |
| Rating         | INTEGER   | Optional user rating (e.g., 1-5)            |
| Comments       | TEXT      | Optional comments with rating               |
| DateStarted    | TEXT      | Date started reading (ISO 8601 string)      |
| DateFinished   | TEXT      | Date finished reading (nullable, ISO 8601)  |
| Status         | INT       | Int to represent enum -> tbr, reading, fin  |


## ♥ Get in Touch!

If you have come across this repo, I'd love to hear from you! Whether you have feedback, suggestions, or just want to say hi, don't hesitate to reach out! ♡
<div align=center>
    <a href="https://www.linkedin.com/in/nahdaa-jawed/" target="_blank">
        <img src="/readme-images/linkedin.png" alt="LinkedIn" style="height:50px" >
    </a>
    <a href="https://github.com/NahdaaJ" target="_blank">
        <img src="/readme-images/github.png" alt="GitHub" style="height:50px" >
    </a>
    <a href="mailto:nahdaajawed@gmail.com?subject=%F0%9F%90%B0%20Reaching%20Out%20From%20Your%20CosyShelf%20Repo&body=Just%20hopping%20by%20to%20say%20hi%20and%20get%20in%20touch!">
        <img src="/readme-images/email.png" alt="Email" style="height:50px" >
    </a>
</div>


