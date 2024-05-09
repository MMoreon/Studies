const express = require('express'),
    app = express(),
    PORT = 3000,
    log = console.log;

let json = [ 
    {
        'id': 12,
        'title': 'Мероприятие',
        'description': 'описание',
        'date': 'дата',
        'time': 'время начала',
        'status': 'предстоит, выполнено, просрочено',
        'priority': 'важное, обычное, можно не делать'
    }
]

app.get(['/tasks', '/'], (req, res) => {
    res.json(json);
});

app.listen(PORT, () => log('http://[::1]:3000'));
