<template>
  <section class="pure-g main">
    <div class="pure-u-1-1">
      <p>GUID (Globally Unique Identifier 全局唯一标识符) 是微软对 DCE (Distributed Computing Environment) UUID (Universally Unique Identifier) 的一种实现。</p>
    </div>

    <div class="pure-u-1-1">
      <button class="pure-button bun-button" @click="newGuid">生成一个 GUID</button>
    </div>
  </section>
</template>

<script>
export default {
    data(){

    },
    methods: {
        newGuid(){
            alert('等开发完成后，这里应该 duang 的一下，出来一个 GUID')
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
</style>
