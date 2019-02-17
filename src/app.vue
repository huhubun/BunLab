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
body
  background-color: rgb(253, 246, 227)

section.main
  margin: 1em auto 90px auto
  width: 90%
  color: rgb(90, 90, 90)
</style>
