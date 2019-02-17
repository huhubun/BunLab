<template>
  <div>
    <lab-header/>
    <div id="url">{{ text }}</div>
    <lab-footer/>
  </div>
</template>

<script>
import LabHeader from './components/lab-header.vue'
import LabFooter from './components/lab-footer.vue'
export default {
  data() {
    return {
      text: 'lab.nzc.me'
    }
  },
  components: {
    LabHeader,
    LabFooter
  }
}
</script>

<style lang="stylus">
body
  background-color: rgb(253, 246, 227)

#url
  color: red
</style>
