// Greet Me functionality
document.getElementById('greetBtn').addEventListener('click', () => {
    const nameInput = document.getElementById('nameInput');
    const resultDiv = document.getElementById('greetResult');
    
    let name = nameInput.value.trim();
    
    // Handle empty input with default value
    if (name === '') {
        name = 'Guest';
    }
    
    resultDiv.textContent = `Hello, ${name}!`;
    resultDiv.classList.add('show');
});

// Add Two Numbers functionality
document.getElementById('addBtn').addEventListener('click', () => {
    const num1Input = document.getElementById('num1Input');
    const num2Input = document.getElementById('num2Input');
    const resultDiv = document.getElementById('addResult');
    
    // Get values and handle invalid input
    const num1 = handleInvalidInput(num1Input.value);
    const num2 = handleInvalidInput(num2Input.value);
    
    const sum = addNumbers(num1, num2);
    
    resultDiv.textContent = `The sum is: ${sum}`;
    resultDiv.classList.add('show');
});

// Helper function to handle invalid input (like your C# version)
function handleInvalidInput(input) {
    const num = parseFloat(input);
    if (isNaN(num)) {
        return 0;
    }
    return num;
}

// Add function (like your C# version)
function addNumbers(a, b) {
    return a + b;
}

// Allow Enter key to trigger buttons
document.getElementById('nameInput').addEventListener('keypress', (e) => {
    if (e.key === 'Enter') {
        document.getElementById('greetBtn').click();
    }
});

document.getElementById('num1Input').addEventListener('keypress', (e) => {
    if (e.key === 'Enter') {
        document.getElementById('num2Input').focus();
    }
});

document.getElementById('num2Input').addEventListener('keypress', (e) => {
    if (e.key === 'Enter') {
        document.getElementById('addBtn').click();
    }
});

