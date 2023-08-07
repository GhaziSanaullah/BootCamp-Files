$(document).ready(function(){

    $('form').submit(function(event) {
        event.preventDefault();
        addTask();
    });
    $('#button').click(function(){
        var toAdd = $('input[name=ListItem]').val().trim();
        if (toAdd !== '') {
            addTask();
            updateCounter();
        }
    });
    function addTask() {
        var toAdd = $('input[name=ListItem]').val().trim();
        if (toAdd !== '') {
            var listItem = '<li><span class="task">' + toAdd + ' ' + '</span><button class="complete">Mark Complete</button><button class="delete">Delete</button></li>';
            $('ul').append(listItem);
            $('input[name=ListItem]').val('');
            updateCounter();
        }
    }

    $(document).on('dblclick', '.task', function(){
        $(this).parent().fadeOut('slow', function() {
            $(this).remove();
            updateCounter();
        });
    });

    $(document).on('click', '.complete', function() {
        $(this).siblings('.task').toggleClass('completed');
        updateCounter();
    });

    $(document).on('click', '.delete', function() {
        $(this).parent().fadeOut('slow', function() {
            $(this).remove();
            updateCounter();
        });
    });

    $('input').focus(function(){
        $(this).val('');
    });

    $('ul').sortable();

    function updateCounter() {
        var completedCount = $('.completed').length;
        $('#counter').text('Completed: ' + completedCount);
    }
});