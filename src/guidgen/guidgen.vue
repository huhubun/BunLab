<template>
  <section class="pure-g main">
    <div class="pure-u-1-1">
      <p>GUID (Globally Unique Identifier 全局唯一标识符) 是微软对 DCE (Distributed Computing Environment) UUID (Universally Unique Identifier) 的一种实现。</p>
    </div>

    <div class="pure-u-1-1">
      <button class="pure-button bun-button" @click="newGuid">生成一个 GUID</button>
    </div>

    <div class="pure-u-1-1 pure-u-sm-1-1 pure-u-md-3-5 pure-u-lg-1-2 guid-history">
      <ul v-for="item in guidHistory" v-bind:key="item.guid">
        <li>
          <small>[{{ dayjs(item.datetime).format('YYYY-MM-DD HH:mm:ss') }}]</small>
          <span>{{ item.guid }}</span>
        </li>
      </ul>
    </div>
  </section>
</template>

<script>
export default {
  data() {
    return {
      guidHistory: [],
      dayjs: dayjs
    }
  },
  methods: {
    newGuid() {
      this.$api.id.newGuid().then(r => {
        this.guidHistory.unshift({
          guid: r.data.guid,
          datetime: new Date()
        })
      })
    }
  }
}
</script>

<style lang="stylus" scoped>
.bun-button
  background-color: initial
  border: 1px solid rgb(90, 90, 90)
  color: rgb(90, 90, 90)

.bun-button:hover
  background-image: none
  background-color: rgb(238, 232, 213)

.bun-button:focus
  background-image: none

.guid-history
  margin-top: 1em
  background-color: #eee8d5

.guid-history ul
  list-style-type: none
  padding-left: 1em
</style>
