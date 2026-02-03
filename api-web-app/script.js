const output = document.getElementById("output");

// Fetch TODOS
function getTodos() {
    fetch("https://jsonplaceholder.typicode.com/todos")
        .then(response => response.json())
        .then(data => {
            output.innerHTML = "<h2>Todos</h2>";
            data.slice(0, 10).forEach(todo => {
                output.innerHTML += `
                    <div class="card">
                        <p><b>Title:</b> ${todo.title}</p>
                        <p><b>Completed:</b> ${todo.completed}</p>
                    </div>
                `;
            });
        });
}

// Fetch COMMENTS
function getComments() {
    fetch("https://jsonplaceholder.typicode.com/comments")
        .then(response => response.json())
        .then(data => {
            output.innerHTML = "<h2>Comments</h2>";
            data.slice(0, 10).forEach(comment => {
                output.innerHTML += `
                    <div class="card">
                        <p><b>Name:</b> ${comment.name}</p>
                        <p><b>Email:</b> ${comment.email}</p>
                        <p>${comment.body}</p>
                    </div>
                `;
            });
        });
}

// Fetch USERS
function getUsers() {
    fetch("https://jsonplaceholder.typicode.com/users")
        .then(response => response.json())
        .then(data => {
            output.innerHTML = "<h2>Users</h2>";
            data.forEach(user => {
                output.innerHTML += `
                    <div class="card">
                        <p><b>Name:</b> ${user.name}</p>
                        <p><b>Email:</b> ${user.email}</p>
                        <p><b>City:</b> ${user.address.city}</p>
                    </div>
                `;
            });
        });
}
