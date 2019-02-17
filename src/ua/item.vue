<template>
  <div class="pure-u-1-1 item">
    <h3 class="title">
      {{item.propertyName}}
      <small>
        <a :href="item.docUrl" target="_blank" title="前往 MDN 了解更多">?</a>
      </small>
    </h3>
    <p>{{item.value}}</p>
  </div>
</template>

<script>
export default {
  props: {
    item: {
      type: Object,
      required: true
    }
  }
}
</script>

<style lang="stylus" scoped>
section.main .title a
  border: 1px solid rgb(114, 114, 114)
  padding: 0 0.5em
  border-radius: 0.5em
  font-size: 0.6em
  text-decoration: none
  color: rgb(90, 90, 90)

section.main .title a:hover
  color: rgb(255, 255, 255)
  background-color: rgb(114, 114, 114)
</style>
