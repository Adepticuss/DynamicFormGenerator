# Dynamic Form Generator
![MIT License](https://img.shields.io/badge/License-MIT-green)
## Overview

The **Dynamic Form Generator** is a Blazor WebAssembly application that allows users to generate dynamic forms based on a JSON configuration. It supports various input types, such as text, number, email, checkbox, and dropdown, along with validation for each type.

## Features
- Support for multiple input field types:
  - **Text** (e.g., for names, addresses)
  - **Email** (with email validation)
  - **Number** (with min/max range validation)
  - **Checkbox** (for true/false input)
  - **Dropdown** (for selecting predefined options)
- Dynamic form generation from JSON configuration.
- Client-side validation for each field type:
  - Required fields
  - Email format validation
  - Numeric value range (min/max)
- Submitting form data as JSON and providing a download link.

## Prerequisites

To run the application, ensure that the following prerequisites are installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet) for building and running the application.
- [Node.js](https://nodejs.org/) (optional for building front-end assets).
- A code editor like **Visual Studio** for editing files.

## Steps to Run the Application
 1) Install Dependencies
 Restore the .NET packages:
 ```bash
 dotnet restore
 ```
 2) Run the Application
 Start the application:
 ```bash
 dotnet run
 ```
 3) After running the above command, open your browser and navigate to https://localhost:7104/ to interact with the form.

### Clone the Repository
First, clone the repository to your local machine:
```bash
git clone https://github.com/Adepticuss/DynamicFormGenerator.git
cd DynamicFormGenerator
```
## Design Considerations and Architecture Decisions
1. Modular Form Generation

    The form is dynamically generated based on a JSON configuration in form-config.json file, allowing for flexibility and extensibility.
- This architecture enables forms to be adjusted without needing to change the application code.
- The form generation is completely modular, where each form field can be defined in the configuration file (form-config.json).

2. Field Validation
- Email Validation: Uses System.Net.Mail.MailAddress to validate the email format. It ensures the email entered follows proper email syntax.
- Number Validation: Checks for numeric input, ensuring that the input is a valid number and falls within the minimum and maximum values defined in the configuration file.
- Required Fields: Ensures that all required fields are completed before submission. This validation is automatically applied based on the Required flag in the configuration.
3. JSON Configuration for Flexibility
- The form configuration is loaded from a JSON file (form-config.json), which defines the fields, types, validation, and other metadata for the form.
- This approach decouples the form logic from the application code, making it easy to modify and extend.

## Assumptions Made During Development
- All fields are assumed to have a label, which is unique within the form.
- Email validation strictly follows the MailAddress format, meaning it allows only properly formatted email addresses.
- Numeric fields are limited to integers, and input is strictly validated to allow only valid numbers.
- The application is designed to run on a Blazor WebAssembly environment, requiring a modern web browser to function correctly.

## Form Submission Output
When the user submits the form, the following actions occur:

1. **Snackbar Notification**:
    A success message is shown in a Snackbar notification with the formatted JSON data. This message is visible for 6 seconds, allowing the user to review the submission data.

    Example of the success message in Snackbar:  

    Form Submitted:
    ```json
    {
    "Name": "Daniil",
    "Email": "Shcherban.daniil@gmail.com",
    "Age": 21,
    "Industry": "Tech",
    "Subscribe to Newsletter": false
    }
    ```

2. **Console Log**:
    The same JSON data is logged to the browser's console. This is useful for debugging or for users who want to inspect the form data in the developer console.

    Example output in the console:  

    Form Submitted:
    ```json
    {
    "Name": "Daniil",
    "Email": "Shcherban.daniil@gmail.com",
    "Age": 21,
    "Industry": "Tech",
    "Subscribe to Newsletter": false
    }
    ```

3. **Download JSON File**:
    A JSON file is generated with the form submission data, and the user is prompted to download it. This file is named `FormData.json` and contains the same data shown in the Snackbar and console log.

    Example content of the downloaded JSON file:  
    
    Form Submitted:  
    ```json
    {
    "Name": "Daniil",
    "Email": "Shcherban.daniil@gmail.com",
    "Age": 21,
    "Industry": "Tech",
    "Subscribe to Newsletter": false
    }
    ```

### How It Works

- **Snackbar**: The success message is displayed using the `MudBlazor` `Snackbar` component, with the data formatted as a readable JSON string.
- **Console Log**: The JSON string is also logged to the browser's console for easy inspection.
- **Download JSON File**: The JSON data is encoded as a `.json` file, and a download link is automatically triggered.

This process allows the user to visually confirm the form submission while also saving or sharing the data in a structured JSON format.


## Troubleshooting
Issue 1: Validation not firing
- Ensure that all required fields are properly set in the JSON configuration and that the MudForm component is correctly referenced.
Issue 2: Unable to run the app
- If you receive errors when running dotnet run, try running the following commands:
```bash
dotnet restore
dotnet build
dotnet run
```

## form-config.json File
The form configuration is stored in a JSON file named form-config.json. This file defines the fields, validation rules, and other metadata needed for generating the form dynamically.
This configuration allows dynamic generation of the form based on the field data such as type (text, email, number, dropdown), validation rules (required, min, max), and field values for dropdown options.

## License
This project is licensed under the MIT License - see the LICENSE file for details.