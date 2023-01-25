function compareTitle(a, b) {
  a = a.title.replace("The ", "");
  b = b.title.replace("The ", "");

  return a.localeCompare(b);
}

function compareYear(a, b) {
  return b.year - a.year;
}

function sortTitle(arr) {
  arr.sort(compareTitle);
  return arr;
}

function sortYear(arr) {
  arr.sort(compareYear);
  return arr;
}

module.exports = {
  compareTitle,
  compareYear,
  sortTitle,
  sortYear,
};
