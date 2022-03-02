module.exports = {
  purge: {
    enabled: true,
    content: [ 
        './Pages/**/*.cshtml',
        './Views/**/*.chstml'
    ]
  },
  darkMode: true, // or 'media' or 'class'
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
