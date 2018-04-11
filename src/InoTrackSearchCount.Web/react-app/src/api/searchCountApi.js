import delay from './delay';

// This file mocks a web API by working with the hard-coded data below.
// It uses setTimeout to simulate the delay of an AJAX call.
// All calls return promises.

const customHeader = {
  'Content-Type': 'application/json',
  'Accept': 'application/json'
};

class SearchCountApi {

  static getFromApi(resolve, reject, text, domain) {
    fetch("http://localhost:64195/api.inotrack/searchcount?text=" + text + "&domain=" + domain, { method: 'GET', headers: customHeader })
    .then(res => res.json())
    .then(
          (response) =>{ resolve(Object.assign([], response)); },
          (error) => { reject(error); }
    );
   }

  static getSearchCount(text, domain) {
     return new Promise((resolve, reject) => {
       setTimeout(() => { SearchCountApi.getFromApi(resolve, reject, text, domain); }, delay);
    });
  }
}

export default SearchCountApi;
