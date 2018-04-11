import React from 'react';
import TextInput from '../common/TextInput';

const SearchCountForm = ({ text, domain, onSearch, onChange, searching, errors}) => {
  return (
    <form>
      <h1>Search Count Page</h1>
      <TextInput
        name="text"
        label="Text"
        value={text}
        onChange={onChange}
        error={errors.text} />

      <TextInput
        name="domain"
        label="Domain"
        value={domain}
        onChange={onChange}
        error={errors.domain} />

      <input
        type="submit"
        disabled={searching}
        value={searching ? 'Searching...' : 'Search'}
        className="btn btn-primary"
        onClick={onSearch}/>
        <br/><br/>
        <hr/>
    </form>
  );
};

SearchCountForm.propTypes = {
  text: React.PropTypes.string,
  domain: React.PropTypes.string,
  onSearch: React.PropTypes.func.isRequired,
  onChange: React.PropTypes.func.isRequired,
  searching: React.PropTypes.bool,
  errors: React.PropTypes.object
};

export default SearchCountForm;
