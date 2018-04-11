import * as types from '../actions/actionTypes';
import initialState from './initialState';

export default function searchReducer(state = initialState.searchResults, action) {
  switch (action.type) {
    case types.LOAD_SEARCH_RESULTS_SUCCESS:
      return action.searchResults;

    default:
      return state;
  }
}
