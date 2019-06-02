<template>
  <div>
    <lab-header/>
    <router-view></router-view>
    <lab-footer/>
  </div>
</template>

<script>
import LabHeader from './components/lab-header.vue'
import LabFooter from './components/lab-footer.vue'
export default {
  components: {
    LabHeader,
    LabFooter
  }
}
</script>

<style lang="stylus">
/* roboto-mono-100 */
@font-face
  font-family: 'Roboto Mono'
  font-style: normal
  font-weight: 100
  src: url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.eot') /* IE9 Compat Modes */
  src: local('Roboto Mono'), local('RobotoMono-Normal'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-100.svg#RobotoMono') format('svg')
  /* Legacy iOS */

/* roboto-mono-300 */
@font-face
  font-family: 'Roboto Mono'
  font-style: normal
  font-weight: 300
  src: url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.eot') /* IE9 Compat Modes */
  src: local('Roboto Mono'), local('RobotoMono-Normal'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-300.svg#RobotoMono') format('svg')
  /* Legacy iOS */

/* roboto-mono-regular */
@font-face
  font-family: 'Roboto Mono'
  font-style: normal
  font-weight: regular
  src: url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.eot') /* IE9 Compat Modes */
  src: local('Roboto Mono'), local('RobotoMono-Normal'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto-mono/roboto-mono-regular.svg#RobotoMono') format('svg')
  /* Legacy iOS */

/* roboto-100 */
@font-face
  font-family: 'Roboto'
  font-style: normal
  font-weight: 100
  src: url('//lib.baomitu.com/fonts/roboto/roboto-100.eot') /* IE9 Compat Modes */
  src: local('Roboto'), local('Roboto-Normal'), url('//lib.baomitu.com/fonts/roboto/roboto-100.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto/roboto-100.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto/roboto-100.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto/roboto-100.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto/roboto-100.svg#Roboto') format('svg')
  /* Legacy iOS */

/* roboto-300 */
@font-face
  font-family: 'Roboto'
  font-style: normal
  font-weight: 300
  src: url('//lib.baomitu.com/fonts/roboto/roboto-300.eot') /* IE9 Compat Modes */
  src: local('Roboto'), local('Roboto-Normal'), url('//lib.baomitu.com/fonts/roboto/roboto-300.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto/roboto-300.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto/roboto-300.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto/roboto-300.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto/roboto-300.svg#Roboto') format('svg')
  /* Legacy iOS */

/* roboto-regular */
@font-face
  font-family: 'Roboto'
  font-style: normal
  font-weight: regular
  src: url('//lib.baomitu.com/fonts/roboto/roboto-regular.eot') /* IE9 Compat Modes */
  src: local('Roboto'), local('Roboto-Normal'), url('//lib.baomitu.com/fonts/roboto/roboto-regular.eot?#iefix') format('embedded-opentype'), url('//lib.baomitu.com/fonts/roboto/roboto-regular.woff2') format('woff2'), url('//lib.baomitu.com/fonts/roboto/roboto-regular.woff') format('woff'), url('//lib.baomitu.com/fonts/roboto/roboto-regular.ttf') format('truetype'), url('//lib.baomitu.com/fonts/roboto/roboto-regular.svg#Roboto') format('svg')
  /* Legacy iOS */

body
  background-color: rgb(253, 246, 227)

section.main
  margin: 1em auto 90px auto
  width: 90%
  color: rgb(90, 90, 90)
</style>
