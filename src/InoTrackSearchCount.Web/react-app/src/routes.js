import React from 'react';
import { Route, IndexRoute } from 'react-router';
import App from './components/App';
import SearchCountPage from './components/search/SearchCountPage';//eslint-disable-line import/no-named-as-default

export default (
  <Route path="/" component={App}>
    <IndexRoute component={SearchCountPage} />
  </Route>
);
