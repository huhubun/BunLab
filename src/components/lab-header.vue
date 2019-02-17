<template>
  <header>
    <div class="pure-menu pure-menu-horizontal">
      <router-link to="/" class="pure-menu-link pure-menu-heading">
        Bun Web Lab
        <small>beta</small>
      </router-link>
    </div>
  </header>
</template>

<script>
export default {

}
</script>

<style lang="stylus" scoped>
header
  padding: 0.6em 3em
  background-color: rgb(238, 232, 213)

header .pure-menu-heading
  text-transform: none
  font-size: 1.1em

header .pure-menu-link
  color: rgb(97, 97, 97)

header .pure-menu-link:hover
  background-color: transparent

header a small
  font-size: 0.6em
  border: 1px solid rgb(114, 114, 114)
  padding: 0.02em 0.4em
  border-radius: 0.8em

header .project-name
  border-left: 1px solid rgb(114, 114, 114)
</style>
