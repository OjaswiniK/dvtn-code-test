The exercise is simple, take some markup from HTML and implement it into a .NET 8 MVC site. 

You can find the source html files in the `/templates` folder. All of the assets have already been placed in the project's `wwwroot` folder. The layout, page header, page footer and page hero have already been implemented as examples.

**Tasks**

- Create and implement the following components on the home page as view components:
  - Image and text panel
  - Large text panel
- Implement a custom error 500 page
- Implement a custom 404 page

**Bonus tasks**

- Set content of view components by passing parameters to them when rendering.
- Add comments.
- Track changes with git commits.
- Demonstrate an understanding of IoC using dependency injection. Feel free to create a class you can inject into a request handler whose output can be rendered to the page.
- Write unit tests for one or more request handlers and/or additional classes you create.

There are some view components (page header, page footer, and page hero) included you can choose to follow as an example for using request handlers.