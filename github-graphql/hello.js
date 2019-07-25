var { graphql, buildSchema } = require('graphql');

var schema = buildSchema(`
  type Query {
    hello: String
  }
`);

var root = { hello: () => 'Hello world!' };

graphql( 'https://api.github.com/graphql'), '{ hello }')
.then((response) => {
  console.log(response);
});
