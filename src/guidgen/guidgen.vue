<template>
  <section class="pure-g main">
    <div class="pure-u-1-1">
      <p>GUID (Globally Unique Identifier 全局唯一标识符) 是微软对 DCE (Distributed Computing Environment) UUID (Universally Unique Identifier) 的一种实现。</p>
    </div>

    <div class="pure-u-1-1">
      <button class="pure-button bun-button" @click="newGuid" v-bind:disabled="isWaitingGuidResponse">
        <v-icon name="circle-notch" spin v-show="isWaitingGuidResponse" />
        生成一个 GUID
        <small>（点击 GUID 可以复制）</small>
      </button>
    </div>

    <div class="pure-u-1-1 pure-u-sm-1-1 pure-u-md-3-5 pure-u-lg-1-2 guid-history">
      <ul v-for="item in guidHistory" v-bind:key="item.guid">
        <li>
          <span class="datetime">[{{ dayjs(item.datetime).format('YYYY-MM-DD HH:mm:ss') }}]</span>
          <span class="guid" v-bind:data-clipboard-text="item.guid">{{ item.guid }}</span>
        </li>
      </ul>
    </div>
  </section>
</template>

<script>
import ClipboardJS from 'clipboard'

export default {
  data() {
    return {
      dayjs: dayjs,
      guidHistory: [],
      isWaitingGuidResponse: false
    }
  },
  methods: {
    newGuid() {
      this.isWaitingGuidResponse = true;

      this.$api.id.newGuid().then(r => {
        this.guidHistory.unshift({
          guid: r.data.guid,
          datetime: new Date()
        })

        this.isWaitingGuidResponse = false
      })
    }
  },
  mounted() {
    var clipboard = new ClipboardJS('.guid')
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

.bun-button .fa-icon
  position: relative
  bottom: -2px
  margin-right: 0.4em

.guid-history
  margin-top: 1em
  background-color: #eee8d5

.guid-history ul
  list-style-type: none
  padding-left: 1em

.guid-history li .datetime
  font-family: 'Roboto Mono', monospace
  font-weight: 300
  font-size: 0.7em

.guid-history li .guid
  font-family: 'Roboto Mono', monospace
  font-weight: 400
  padding: 0 0.5em

.guid-history li .guid:hover
  background-color: rgb(217, 210, 194)
  cursor: pointer
</style>
