import React, {PropTypes} from 'react';
import SearchListRow from './SearchListRow';

const SearchList = ({ searchResults }) => {
  return (
    <table className="table">
      <tbody>
        {searchResults.map((result, index) =>
          <SearchListRow key={index} result={result}/>
      )}
      </tbody>
    </table>
  );
};

SearchList.propTypes = {
  searchResults: PropTypes.array.isRequired
};

export default SearchList;
