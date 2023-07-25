// Initialize a variable to keep track of the current page number
let currentPage = 1;
const blogPostsContainer = $('#blogPosts');
const loadingSpinner = $('#loadingSpinner');
const boody=$('#blogPosts')
// Load initial blog posts when the page loads
$(document).ready(function () 
{
    loadBlogPosts();
});
$("#Load_More").click(function () 
{
    // Call the function to fetch and display the next set of blog posts
    currentPage++;
    loadBlogPosts();
});
// Use jQuery to handle the click event on the "Load More" button
$("#next").click(function () 
{
    // Call the function to fetch and display the next set of blog posts
    currentPage++;
    blogPostsContainer.empty();
    loadBlogPosts();
});
$("#prev").click(function () 
{
    // Call the function to fetch and display the next set of blog posts
    currentPage--;
    blogPostsContainer.empty();
    loadBlogPosts();
});

// Function to fetch blog posts from the server and display them
function loadBlogPosts() 
{
    loadingSpinner.show();
    boody.hide;
    // Send an AJAX request to the server endpoint
    $.ajax({
        url: "https://jsonplaceholder.typicode.com/posts",
        type: "GET",
        data: 
        {
            _page: currentPage, // Send the current page number as a parameter
            _limit: 5 // Set the number of posts to load per request (e.g., 5 posts per page)
        },
        success: function (data) 
        {
            setTimeout(function () {
                loadingSpinner.hide();})
            // If the AJAX request is successful, handle the response data
            // Loop through the data array and dynamically add the new blog posts
            data.forEach(function (post) 
            {
                // Create a new div element for each blog post
                const postDiv = $("<div>").addClass("blogPost").text(post.title);
                // Append the blog post to the "blogPosts" div
                loadingSpinner.show();
                $("#blogPosts").append(postDiv);
                boody.show;
            });
        },
        error: function () 
        {
            // If there's an error with the AJAX request, handle it here
            console.log("Error fetching blog posts.");
            loadingSpinner.hide();
        }
    });
}