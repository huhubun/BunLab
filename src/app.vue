<template>
  <div id="app">
    <div id="url">{{ text }}</div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      text: 'lab.nzc.me'
    }
  }
}
</script>

<style lang="stylus" scoped>
#url
  color: red
</style>
