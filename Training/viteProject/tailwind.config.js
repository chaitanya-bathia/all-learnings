module.exports = {
  content: ["./Tailwind/**/*.{html,js}", "./node_modules/tw-elements/dist/js/**/*.js"],
  theme: {
    extend: {
      colors: {
        primary: '#FF6363',
        secondary: {
          100: '#E2E2D5',
          200: '#888883'
        }
      }
    },
    screens:{
      'sm':'568px',
      'md':'768px',
      'lg':'1024px'
    }
  },
  plugins: [require('tw-elements/dist/plugin')],
}
