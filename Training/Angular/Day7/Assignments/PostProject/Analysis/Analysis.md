1. The Post Project contains one custom Component, PostList which holds a list of posts, (contained in an array of type Post).
2. This post List is then passed via an event by the PostList component using the @Output functionality to the parent component.
3. The parent component then accepts the list of posts and stores it in a local array.
4. This list of posts is then iterated over in the parent component, and the data is displayed in a table.