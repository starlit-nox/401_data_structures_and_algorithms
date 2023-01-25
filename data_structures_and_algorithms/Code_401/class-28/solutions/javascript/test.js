const { Movies } = require("./movies");
const { sortTitle, sortYear, compareTitle, compareYear } = require("./sort");

describe("Sorters", () => {
  it("can sort movies by year", () => {
    const movies = sortYear(Movies);
    expect(movies.map((m) => m.title)).toEqual([
      "The Intouchables",
      "Valkyrie",
      "Ratatouille",
      "Stardust",
      "City of God",
      "Memento",
      "The Shawshank Redemption",
      "Beetlejuice",
      "Crocodile Dundee",
      "The Cotton Club",
    ]);
  });

  it("can sort movies by title", () => {
    const movies = sortTitle(Movies);
    expect(movies.map((m) => m.title)).toEqual([
      "Beetlejuice",
      "City of God",
      "The Cotton Club",
      "Crocodile Dundee",
      "The Intouchables",
      "Memento",
      "Ratatouille",
      "The Shawshank Redemption",
      "Stardust",
      "Valkyrie",
    ]);
  });
});

describe("Comparison", () => {
  it("can compare movies by year descending", () => {
    expect(
      compareYear(
        { title: "A", year: 2000, genres: [] },
        { title: "B", year: 1998, genres: [] }
      )
    ).toBeLessThan(0);
    expect(
      compareYear(
        { title: "B", year: 1998, genres: [] },
        { title: "A", year: 2000, genres: [] }
      )
    ).toBeGreaterThan(0);
    expect(
      compareYear(
        { title: "A", year: 2000, genres: [] },
        { title: "A", year: 2000, genres: [] }
      )
    ).toBe(0);
  });
});
