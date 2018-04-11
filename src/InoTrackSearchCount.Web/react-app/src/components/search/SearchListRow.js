import React, {PropTypes} from 'react';

const SearchListRow = ({ result }) => {
  return (
    <tr>
      <td>{result}</td>
    </tr>
  );
};

SearchListRow.propTypes = {
  result: PropTypes.string.isRequired
};

export default SearchListRow;
